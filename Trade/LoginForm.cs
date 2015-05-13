using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trade
{
    public partial class LoginForm : Form
    {
        Point m_mousePos;
        Boolean m_isMouseDown;
        public LoginForm()
        {
            InitializeComponent();

            combo_server.SelectedIndex = 0;
        }

        #region 隐藏标题栏后移动窗口

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            m_mousePos = Cursor.Position;
            m_isMouseDown = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            m_isMouseDown = false;
            this.Focus();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (m_isMouseDown)
            {
                Point tempPos = Cursor.Position;
                this.Location = new Point(Location.X + (tempPos.X - m_mousePos.X), Location.Y + (tempPos.Y - m_mousePos.Y));
                m_mousePos = Cursor.Position;
            }
        }

        #endregion

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}
