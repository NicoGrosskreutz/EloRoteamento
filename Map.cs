using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace EloRoteamento
{
    public partial class Map : Form
    {
        /// <summary>
        ///  Lista aux para a tela
        /// </summary>
        private List<Reference> Points { get; set; } = null;

        private GMapOverlay markersOverlay = null;

        private GMapOverlay referencesOverlay = null;

        private GMarkerGoogle marker = null;

        private List<Reference> marcas = null;

        public Map()
        {
            InitializeComponent();

            gMap.DragButton = MouseButtons.Left;

            this.StartPosition = FormStartPosition.CenterParent;
            this.WindowState = FormWindowState.Maximized;

            this.txVendedor.ReadOnly = true;
            this.txDataInicial.ReadOnly = true;
            this.txDataFinal.ReadOnly = true;

            this.txVendedor.BackColor = Color.White;
            this.txDataInicial.BackColor = Color.White;
            this.txDataFinal.BackColor = Color.White;

            LoadTable();      
        }

        public Map(string[] args)
        {
            InitializeComponent();

            gMap.DragButton = MouseButtons.Left;

            this.StartPosition = FormStartPosition.CenterParent;
            this.WindowState = FormWindowState.Maximized;

            this.txVendedor.ReadOnly = true;
            this.txDataInicial.ReadOnly = true;
            this.txDataFinal.ReadOnly = true;

            this.txVendedor.BackColor = Color.White;
            this.txDataInicial.BackColor = Color.White;
            this.txDataFinal.BackColor = Color.White;

            LoadTable();

            gMap.MapProvider = OpenStreetMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMap.Position = new PointLatLng(-14.2350, -51.9253);
            gMap.Zoom = 5;

            LoadLocalization(args);
        }

        private bool LoadLocalization(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    var points = new List<Reference>();

                    args.ToList().ForEach(aux =>
                    {
                        if (aux.ToLower().StartsWith("vendedor="))
                            txVendedor.Text = aux.Replace("vendedor=", "");

                        if (aux.ToLower().StartsWith("locais="))
                        {
                            string[] positions = aux.Replace("locais=", "").Split(';');

                            positions.ToList().ForEach((position) =>
                            {
                                try
                                {
                                    string[] values = position.Split(new char[] { ',' , '&' });

                                    points.Add(
                                        new Reference(
                                            new PointLatLng(
                                                TryParseDouble(values[0].Replace(" ", "")), 
                                                TryParseDouble(values[1].Replace(" ", ""))),
                                                values[2]));

                                    grid.Rows.Add(values[0].Replace(" ", ""), values[1].Replace(" ", ""), values[2]);
                                }
                                catch
                                {
                                    Console.WriteLine("Valor de posição inválida!");
                                }
                            });

                            txDataInicial.Text = grid.Rows[0].Cells[2].Value.ToString();
                            txDataFinal.Text = grid.Rows[grid.Rows.Count - 1].Cells[2].Value.ToString();
                            
                            this.Points = points;
                        }

                        if (aux.ToLower().StartsWith("marcas="))
                        {
                            marcas = new List<Reference>();

                            string[] positions = aux.Replace("marcas=", "").Split(';');

                            positions.ToList().ForEach(position => 
                            {
                                try
                                {
                                    string[] values = position.Split(new[] { ',', '&' });

                                    string valueAux = "";
                                    if (values.Count() > 2)
                                        valueAux = values[2];

                                    marcas.Add(new Reference(
                                        new PointLatLng(
                                            TryParseDouble(values[0].Replace(" ", "")), 
                                            TryParseDouble(values[1].Replace(" ", ""))), 
                                            valueAux));

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Erro: " + ex.ToString());
                                }
                            });
                        }
                    });

                    if (this.Points != null)
                        if (this.Points.Count > 0)
                        {
                            gMap.Position = Points.First() != null ? Points.First().Point : new PointLatLng(-14.2350, -51.9253);

                            List<PointLatLng> aux = new List<PointLatLng>();
                            Points.ForEach(p => aux.Add(p.Point));

                            GMapRoute route = new GMapRoute(aux, "caminhoVendedor");
                            GMapOverlay routes = new GMapOverlay("routes");
                            route.Stroke = new Pen(Color.Red);
                            route.Stroke.Width = 4;
                            route.Stroke.DashStyle = DashStyle.Solid;

                            route.Stroke.StartCap = LineCap.NoAnchor;
                            route.Stroke.EndCap = LineCap.ArrowAnchor;
                            route.Stroke.LineJoin = LineJoin.Round;

                            GMarkerGoogle marker;
                            Points.ForEach(p => 
                            {
                                marker = new GMarkerGoogle(p.Point, GMarkerGoogleType.red_small);

                                SetToolTip(marker, p.ToolTip);

                                routes.Markers.Add(marker);
                            });

                            routes.Routes.Add(route);
                            gMap.Overlays.Add(routes);
                            gMap.Zoom = 14;
                        }
                }
                else
                {
                    MessageBox.Show("Erro ao informar parâmetros para o aplicativo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao informar parâmetros para o aplicativo! \n" + ex.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
                return false;
            }
            finally
            {
                if (marcas != null)
                    AddMarkers(marcas);
            }
        }

        private double TryParseDouble(string value)
        {
            return double.TryParse(value.Replace(".", ","), out double aux) ? aux : 0;
        }

        private void Map_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadTable()
        {
            this.grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grid.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.grid.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.grid.MultiSelect = false;

            grid.Columns.Add("Latitude", "Latitude");
            grid.Columns.Add("Longitude", "Longitude");
            grid.Columns.Add("DataHora", "Data/Hora");

            grid.Columns["Latitude"].Visible = false;
            grid.Columns["Longitude"].Visible = false;
            grid.Columns["DataHora"].Visible = true;
            grid.Columns["DataHora"].Width = grid.Width - 20;
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (markersOverlay != null)
                gMap.Overlays.Remove(markersOverlay);

            if (grid.SelectedRows.Count > 0)
            {
                var p = new PointLatLng(TryParseDouble(grid.CurrentRow.Cells[0].Value.ToString()), TryParseDouble(grid.CurrentRow.Cells[1].Value.ToString()));
                string tooltip = grid.CurrentRow.Cells[2].Value.ToString();

                markersOverlay = new GMapOverlay("markers");
                marker = new GMarkerGoogle(p, GMarkerGoogleType.green_small);

                SetToolTip(marker, tooltip);

                markersOverlay.Markers.Add(marker);
                gMap.Overlays.Add(markersOverlay);
                gMap.Position = p;
                gMap.Zoom = 16;
                gMap.Refresh();
            }
        }
        
        private void AddMarkers(List<Reference> points)
        {
            referencesOverlay = new GMapOverlay("references");

            points.ForEach(p => 
            {
                marker = new GMarkerGoogle(p.Point, GMarkerGoogleType.blue_small);

                SetToolTip(marker, p.ToolTip);

                referencesOverlay.Markers.Add(marker);
                gMap.Overlays.Add(referencesOverlay);
            });
            
            gMap.Refresh();
        }

        private void Map_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        public class Reference
        {
            public PointLatLng Point { get; set; }
            public string ToolTip { get; set; }

            public Reference(PointLatLng point, string toolTip)
            {
                Point = point;
                ToolTip = toolTip;
            }
        }

        private void btnMaisZoom_Click(object sender, EventArgs e)
        {
            if (gMap.Zoom <= 18)
                gMap.Zoom += 2;
        }

        private void btnMenosZoom_Click(object sender, EventArgs e)
        {
            if (gMap.Zoom >= 6)
                gMap.Zoom -= 2;
        }

        private void Map_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void SetToolTip(GMarkerGoogle marker, string tooltip)
        {
            if (!string.IsNullOrEmpty(tooltip.Trim()))
            {
                marker.ToolTipText = tooltip;
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);
            }
        }
    }
}
