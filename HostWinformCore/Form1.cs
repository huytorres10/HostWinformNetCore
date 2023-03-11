using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostWinformCore
{
    public partial class Form1 : Form
    {
        private readonly ILogger<Form1> _logger;
        private readonly AppContext _context;
        public Form1(ILogger<Form1> logger, AppContext context)
        {
            _logger = logger;
            _context = context;

            //Ghi thử một log thông báo ra test.txt và blog.db rằng "app started!"
            _logger.LogWarning("app started!");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = _context.Configs.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nếu chưa có dữ liệu trong table Customers thì thêm vào 3 cái
            //if (_context.Configs.Count() == 0)
            //{
                _context.Configs.Add(new Config { Name = 1, Value = 1, Note = 1 });
                _context.Configs.Add(new Config { Name = 2, Value = 2, Note = 2 });
                _context.Configs.Add(new Config { Name = 3, Value = 3, Note = 3 });
                _context.SaveChanges();
            //}
                dataGridView1.DataSource = _context.Configs.ToList();

            //rồi sau đó show ra id của thằng đầu tiên.
            MessageBox.Show(_context.Configs.First().Id.ToString());
        }
    }
}
