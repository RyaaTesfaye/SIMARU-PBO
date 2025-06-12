using RUSUNAWAAA.Models;
using RUSUNAWAAA.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RUSUNAWAAA.Utils;

namespace RUSUNAWAAA.View.Umum
{
    public partial class Virtual_Tour_Umum : Form
    {
        private readonly VirtualTourService _service = new VirtualTourService();
        private List<MediaVirtual> _semuaMedia;

        private int _halamanSaatIni = 1;
        private readonly int _itemPerHalaman = 3;   
        public Virtual_Tour_Umum()
        {
            InitializeComponent();
        }
        private void Virtual_Tour_Umum_Load(object sender, EventArgs e)
        {
            try
            {
                _semuaMedia = _service.GetAllMedia();
                DisplayCurrentPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data virtual tour: " + ex.Message);
            }
        }
        private void DisplayCurrentPage()
        {
            // Ambil 3 item untuk halaman saat ini
            var mediaUntukHalamanIni = _semuaMedia
                .Skip((_halamanSaatIni - 1) * _itemPerHalaman)
                .Take(_itemPerHalaman)
                .ToList();
            // Slot 1
            UpdateSlot(picbox1, lblKeterangan1, mediaUntukHalamanIni.ElementAtOrDefault(0));
            // Slot 2
            UpdateSlot(picbox2, lblKeterangan2, mediaUntukHalamanIni.ElementAtOrDefault(1));
            // Slot 3
            UpdateSlot(picbox3, lblKeterangan3, mediaUntukHalamanIni.ElementAtOrDefault(2));

            UpdatePagingButtons();
        }
        private void UpdatePagingButtons()
        {
            int totalHalaman = (_semuaMedia != null && _semuaMedia.Any())
                ? (int)Math.Ceiling((double)_semuaMedia.Count / _itemPerHalaman)
                : 1;

            btnNext.Enabled = (_halamanSaatIni < totalHalaman);
            btnPrev.Enabled = (_halamanSaatIni > 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _halamanSaatIni++;
            DisplayCurrentPage();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _halamanSaatIni--;
            DisplayCurrentPage();
        }
        private void UpdateSlot(PictureBox picbox, Label label, MediaVirtual media)
        {
            if (media != null)
            {

                picbox.Visible = true;
                label.Visible = true;
                label.Text = media.NamaFile;

                if (!string.IsNullOrEmpty(media.PathMedia) && File.Exists(media.PathMedia))
                {
                    try
                    {
                        using (var bmpTemp = new Bitmap(media.PathMedia))
                        {
                            picbox.Image = new Bitmap(bmpTemp);
                        }
                    }
                    catch { picbox.Image = null; }
                }
                else
                {
                    picbox.Image = null; 
                }
            }
            else
            {
               
                picbox.Visible = false;
                label.Visible = false;
            }
        }
        private void ToDaftarUnit_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<DaftarUnit_Umum>(this);
            command.Execute();
        }

        private void ToDashboard_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Dashboard_umum>(this);
            command.Execute();
        }

        private void ToPengajuanSewa_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<PengajuanSewa_Umum>(this);
            command.Execute();
        }

        private void ToUlasan_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Ulasan_Umum>(this);
            command.Execute();
        }

        private void ToTataTertib_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Tatatertib_Umum>(this);
            command.Execute();
        }

        private void ToKontakLokasi_UM(object sender, EventArgs e)
        {
            var command = new NavigateToFormCommand<Kontaklokasi_Umum>(this);
            command.Execute();
        }
    }
}
