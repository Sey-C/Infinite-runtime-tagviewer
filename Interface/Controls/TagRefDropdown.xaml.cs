﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assembly69.Interface.Controls {
    /// <summary>
    /// Interaction logic for tagref_dropdown.xaml
    /// </summary>
    public partial class TagRefDropdown : Window
    {
        public TagRefDropdown()
        {
            InitializeComponent();
        }

        public MainWindow MainWindow;

        private void Window_Deactivated(object sender, EventArgs e)
        {
            closethis();
        }

        public bool is_closing;



        public void closethis()
        {
            if (!is_closing)
            {
                is_closing = true;
                Close();
            }
        }


        private void Searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = search_block.Text;
            foreach (TreeViewItem tv in tag_select_panel.Items)
            {
                if (!tv.Header.ToString().Contains(search))
                {
                    tv.Visibility = Visibility.Collapsed;
                    foreach (TreeViewItem tc in tv.Items)
                    {
                        if (tc.Header.ToString().Contains(search))
                        {
                            tc.Visibility = Visibility.Visible;
                            tv.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            tc.Visibility = Visibility.Collapsed;
                        }
                    }
                }
                else
                {
                    tv.Visibility = Visibility.Visible;
                    foreach (TreeViewItem tc in tv.Items)
                    {
                        tc.Visibility = Visibility.Visible;

                    }

                }

            }
        }
    }
}