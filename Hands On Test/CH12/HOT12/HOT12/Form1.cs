﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT12
{
    public partial class Form1 : Form
    {
        List<Hash> hashes = new List<Hash>();
        {
            new Hash("123456","e10adc3949ba59abbe56e057f20f883e"),
            new Hash("123456789", "25f9e794323b453885f5181f1b624d0b"),
            new Hash("qwerty", "d8578edf8458ce06fbc5bb76a58c5ca4"),
            new Hash("111111", "96e79218965eb72c92a549dd5a330112"),
            new Hash("password", "5f4dcc3b5aa765d61d8327deb882cf99"),
            new Hash("qwertyuiop", "6eea9b7ef19179a06954edd0f6c05ceb"),
            new Hash("123321", "c8837b23ff8aaa8a2dde915473ce0991"),
            new Hash("google", "c822c1b63853ed273b89687ac505f9fa"),
            new Hash("P@ssw0rd", "161ebd7d45089b3446ee4e0d86dbcf92"),
            new Hash("Tr0ub4dor&3", "4ece57a61323b52ccffdbef021956754")

    };
        public Form1()
        {
            InitializeComponent();
        }

    private void ConvertBtn_Click(object sender, EventArgs e)
    {

    }

    public string CrackPassword(string hash)
        {
            for (int i = 0; i < hash.Count; i++)
            {
                if (hash[i] == md5Hash)
                {
                    return 
                }
                else
                {

                }
            }
        }
    }
}
