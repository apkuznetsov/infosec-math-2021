﻿using System;
using System.Windows.Forms;

namespace Rsa
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                long p = Convert.ToInt64(nudP.Text);
                long q = Convert.ToInt64(nudQ.Text);
                long d;
                long n;

                RsaText.Encrypt(p, q, out d, out n);
                nudD.Value = d;
                nudN.Value = n;

                MessageBox.Show("ТЕКСТ ЗАШИФРОВАН");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                long d = Convert.ToInt64(nudD.Text);
                long n = Convert.ToInt64(nudN.Text);

                RsaText.Decrypt(d, n);

                MessageBox.Show("ТЕКСТ РАСШИФРОВАН");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
