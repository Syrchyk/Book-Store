using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool isInList = false;
        private bool isInList1 = false;
        private void OrderB_MouseEnter(object sender, MouseEventArgs e)
        {
            OrderB.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            ((TextBlock)OrderB.Child).Foreground = new SolidColorBrush(Color.FromRgb(1, 52, 64));

        }

        private void OrderB_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            OrderLB.Items.Clear();
        }

        private void OrderB_MouseLeave(object sender, MouseEventArgs e)
        {
            OrderB.Background = new SolidColorBrush(Color.FromRgb(1, 52, 64));
            ((TextBlock)OrderB.Child).Foreground = Brushes.White;
        }

        private void addB_MouseEnter(object sender, MouseEventArgs e)
        {
            addB.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            ((TextBlock)addB.Child).Foreground = new SolidColorBrush(Color.FromRgb(1, 52, 64));
        }

        private void addB_MouseLeave(object sender, MouseEventArgs e)
        {
            addB.Background = new SolidColorBrush(Color.FromRgb(1, 52, 64));
            ((TextBlock)addB.Child).Foreground = Brushes.White;

        }

        private void addB_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (isValid())
            {
                #region Grid
                Grid grid = new Grid();
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(30) });
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(165) });
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(135) });
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(20) });
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.Background = Brushes.Crimson;
                #endregion
                #region TextBlock1
                TextBlock textBlock1 = new TextBlock();
                grid.Children.Add(textBlock1);
                Grid.SetColumn(textBlock1, 0);
                Grid.SetRow(textBlock1, 0);
                Grid.SetRowSpan(textBlock1, 3);
                textBlock1.HorizontalAlignment = HorizontalAlignment.Center;
                textBlock1.VerticalAlignment = VerticalAlignment.Center;
                textBlock1.Foreground = Brushes.White;
                textBlock1.Text = numberTB.Text;
                #endregion
                #region TextBlock2
                TextBlock textBlock2 = new TextBlock();
                grid.Children.Add(textBlock2);
                Grid.SetColumn(textBlock2, 1);
                Grid.SetRow(textBlock2, 0);
                textBlock2.Text = "Name: " + nameTB.Text;
                textBlock2.Margin = new Thickness(5);
                textBlock2.Foreground = Brushes.White;
                #endregion
                #region TextBlock3
                TextBlock textBlock3 = new TextBlock();
                grid.Children.Add(textBlock3);
                Grid.SetColumn(textBlock3, 1);
                Grid.SetRow(textBlock3, 1);
                textBlock3.Text = "Autor: " + autorTB.Text;
                textBlock3.Margin = new Thickness(5);
                textBlock3.Foreground = Brushes.White;
                #endregion
                #region TextBlock4
                TextBlock textBlock4 = new TextBlock();
                grid.Children.Add(textBlock4);
                Grid.SetColumn(textBlock4, 1);
                Grid.SetRow(textBlock4, 2);
                textBlock4.Text = "Edition: " + editionTB.Text;
                textBlock4.Margin = new Thickness(5);
                textBlock4.Foreground = Brushes.White;
                #endregion
                #region TextBlock5
                TextBlock textBlock5 = new TextBlock();
                grid.Children.Add(textBlock5);
                Grid.SetColumn(textBlock5, 2);
                Grid.SetRow(textBlock5, 0);
                textBlock5.Text = "Number of pages: " + NoPTB.Text;
                textBlock5.Margin = new Thickness(5);
                textBlock5.Foreground = Brushes.White;
                #endregion
                #region TextBlock6
                TextBlock textBlock6 = new TextBlock();
                grid.Children.Add(textBlock6);
                Grid.SetColumn(textBlock6, 2);
                Grid.SetRow(textBlock6, 2);
                textBlock6.Text = "Price: " + priceTB.Text;
                textBlock6.Margin = new Thickness(5);
                textBlock6.Foreground = Brushes.White;
                #endregion
                #region BorderBuy
                #region TextBlockToBuyBorder
                TextBlock TextBlockToBuyBorder = new TextBlock();
                TextBlockToBuyBorder.Text = "Buy";
                TextBlockToBuyBorder.VerticalAlignment = VerticalAlignment.Center;
                TextBlockToBuyBorder.HorizontalAlignment = HorizontalAlignment.Center;
                TextBlockToBuyBorder.Foreground = Brushes.White;
                #endregion
                Border border1 = new Border();
                grid.Children.Add(border1);
                Grid.SetColumn(border1, 2);
                Grid.SetRow(border1, 1);
                border1.Margin = new Thickness(20, 2, 20, 2);
                border1.CornerRadius = new CornerRadius(10);
                border1.BorderThickness = new Thickness(2);
                border1.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 52, 64));
                border1.Background = new SolidColorBrush(Color.FromRgb(1, 52, 64));
                border1.MouseEnter += BuyB_MouseEnter;
                border1.MouseLeave += BuyB_MouseLeave;
                border1.MouseLeftButtonUp += BuyB_MouseLeftButtonUp;
                border1.Child = TextBlockToBuyBorder;
                #endregion
                #region BorderDelete
                #region TextBlockToDeleteBorder
                TextBlock TextBlockToDeleteBorder = new TextBlock();
                TextBlockToDeleteBorder.Text = "X";
                TextBlockToDeleteBorder.Foreground = new SolidColorBrush(Color.FromRgb(1, 52, 64));
                TextBlockToDeleteBorder.VerticalAlignment = VerticalAlignment.Center;
                TextBlockToDeleteBorder.HorizontalAlignment = HorizontalAlignment.Center;
                #endregion
                Border border2 = new Border();
                grid.Children.Add(border2);
                Grid.SetColumn(border2, 3);
                Grid.SetRow(border2, 0);
                border2.CornerRadius = new CornerRadius(5);
                border2.Background = Brushes.White;
                border2.MouseEnter += DeleteB_MouseEnter;
                border2.MouseLeave += DeleteB_MouseLeave;
                border2.MouseLeftButtonUp += DeleteB_MouseLeftButtonUp;
                border2.Child = TextBlockToDeleteBorder;
                #endregion
                #region Border
                Border border = new Border();
                border.CornerRadius = new CornerRadius(10);
                border.BorderThickness = new Thickness(3);
                border.BorderBrush = Brushes.Crimson;
                border.Child = grid;
                #endregion
                if (AddLB.Items.Count != 0)
                {
                    foreach (Border item in AddLB.Items)
                    {
                        if (((TextBlock)((Grid)item.Child).Children[1]).Text == textBlock2.Text && ((TextBlock)((Grid)item.Child).Children[2]).Text == textBlock3.Text && ((TextBlock)((Grid)item.Child).Children[3]).Text == textBlock4.Text && ((TextBlock)((Grid)item.Child).Children[4]).Text == textBlock5.Text && ((TextBlock)((Grid)item.Child).Children[5]).Text == textBlock6.Text)
                        {
                            ((TextBlock)((Grid)item.Child).Children[0]).Text = (Convert.ToInt32(numberTB.Text) + Convert.ToInt32(((TextBlock)((Grid)item.Child).Children[0]).Text)).ToString();
                            isInList = true;
                            break;
                        }
                        else
                        {
                            isInList = false;
                        }
                    }
                    if(!isInList)
                    {
                        AddLB.Items.Add(border);
                        isInList = false;
                    }

                }
                else
                {
                    AddLB.Items.Add(border);
                }
            }
        }

        private Border newBorder(Border border)
        {
            #region Grid
            Grid grid = new Grid();
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(30) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(165) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(135) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(20) });
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.Background = Brushes.Crimson;
            #endregion
            #region TextBlock1
            TextBlock textBlock1 = new TextBlock();
            grid.Children.Add(textBlock1);
            Grid.SetColumn(textBlock1, 0);
            Grid.SetRow(textBlock1, 0);
            Grid.SetRowSpan(textBlock1, 3);
            textBlock1.HorizontalAlignment = HorizontalAlignment.Center;
            textBlock1.VerticalAlignment = VerticalAlignment.Center;
            textBlock1.Foreground = Brushes.White;
            textBlock1.Text = "1";
            #endregion
            #region TextBlock2
            TextBlock textBlock2 = new TextBlock();
            grid.Children.Add(textBlock2);
            Grid.SetColumn(textBlock2, 1);
            Grid.SetRow(textBlock2, 0);
            textBlock2.Text = ((TextBlock)((Grid)border.Child).Children[1]).Text;
            textBlock2.Margin = new Thickness(5);
            textBlock2.Foreground = Brushes.White;
            #endregion
            #region TextBlock3
            TextBlock textBlock3 = new TextBlock();
            grid.Children.Add(textBlock3);
            Grid.SetColumn(textBlock3, 1);
            Grid.SetRow(textBlock3, 1);
            textBlock3.Text = ((TextBlock)((Grid)border.Child).Children[2]).Text;
            textBlock3.Margin = new Thickness(5);
            textBlock3.Foreground = Brushes.White;
            #endregion
            #region TextBlock4
            TextBlock textBlock4 = new TextBlock();
            grid.Children.Add(textBlock4);
            Grid.SetColumn(textBlock4, 1);
            Grid.SetRow(textBlock4, 2);
            textBlock4.Text = ((TextBlock)((Grid)border.Child).Children[3]).Text;
            textBlock4.Margin = new Thickness(5);
            textBlock4.Foreground = Brushes.White;
            #endregion
            #region TextBlock5
            TextBlock textBlock5 = new TextBlock();
            grid.Children.Add(textBlock5);
            Grid.SetColumn(textBlock5, 2);
            Grid.SetRow(textBlock5, 0);
            textBlock5.Text = ((TextBlock)((Grid)border.Child).Children[4]).Text;
            textBlock5.Margin = new Thickness(5);
            textBlock5.Foreground = Brushes.White;
            #endregion
            #region TextBlock6
            TextBlock textBlock6 = new TextBlock();
            grid.Children.Add(textBlock6);
            Grid.SetColumn(textBlock6, 2);
            Grid.SetRow(textBlock6, 2);
            textBlock6.Text = ((TextBlock)((Grid)border.Child).Children[5]).Text;
            textBlock6.Margin = new Thickness(5);
            textBlock6.Foreground = Brushes.White;
            #endregion
            #region BorderBuy
            #region TextBlockToBuyBorder
            TextBlock TextBlockToBuyBorder = new TextBlock();
            TextBlockToBuyBorder.Text = ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text;
            TextBlockToBuyBorder.VerticalAlignment = VerticalAlignment.Center;
            TextBlockToBuyBorder.HorizontalAlignment = HorizontalAlignment.Center;
            TextBlockToBuyBorder.Foreground = Brushes.White;
            #endregion
            Border border1 = new Border();
            grid.Children.Add(border1);
            Grid.SetColumn(border1, 2);
            Grid.SetRow(border1, 1);
            border1.Margin = new Thickness(20, 2, 20, 2);
            border1.CornerRadius = new CornerRadius(10);
            border1.BorderThickness = new Thickness(2);
            border1.BorderBrush = new SolidColorBrush(Color.FromRgb(1, 52, 64));
            border1.Background = new SolidColorBrush(Color.FromRgb(1, 52, 64));
            border1.MouseEnter += BuyB_MouseEnter;
            border1.MouseLeave += BuyB_MouseLeave;
            border1.MouseLeftButtonUp += BuyB_MouseLeftButtonUp;
            border1.Child = TextBlockToBuyBorder;
            #endregion
            #region BorderDelete
            #region TextBlockToDeleteBorder
            TextBlock TextBlockToDeleteBorder = new TextBlock();
            TextBlockToDeleteBorder.Text = "X";
            TextBlockToDeleteBorder.Foreground = new SolidColorBrush(Color.FromRgb(1, 52, 64));
            TextBlockToDeleteBorder.VerticalAlignment = VerticalAlignment.Center;
            TextBlockToDeleteBorder.HorizontalAlignment = HorizontalAlignment.Center;
            #endregion
            Border border2 = new Border();
            grid.Children.Add(border2);
            Grid.SetColumn(border2, 3);
            Grid.SetRow(border2, 0);
            border2.CornerRadius = new CornerRadius(5);
            border2.Background = Brushes.White;
            border2.MouseEnter += DeleteB_MouseEnter;
            border2.MouseLeave += DeleteB_MouseLeave;
            border2.MouseLeftButtonUp += DeleteB_MouseLeftButtonUp;
            border2.Child = TextBlockToDeleteBorder;
            #endregion
            #region Border
            Border border11 = new Border();
            border11.CornerRadius = new CornerRadius(10);
            border11.BorderThickness = new Thickness(3);
            border11.BorderBrush = Brushes.Crimson;
            border11.Child = grid;
            #endregion
            return border11;
        }


        private bool isValid()
        {
            if(String.IsNullOrWhiteSpace(nameTB.Text))
            {
                ((Border)((DockPanel)nameTB.Parent).Parent).BorderBrush = Brushes.Red;
                return false;
            }
            else
            {
                ((Border)((DockPanel)nameTB.Parent).Parent).BorderBrush = Brushes.Black;
            }
            if (String.IsNullOrWhiteSpace(autorTB.Text))
            {
                ((Border)((DockPanel)autorTB.Parent).Parent).BorderBrush = Brushes.Red;
                return false;
            }
            else
            {
                ((Border)((DockPanel)autorTB.Parent).Parent).BorderBrush = Brushes.Black;
            }
            if (String.IsNullOrWhiteSpace(editionTB.Text))
            {
                ((Border)((DockPanel)editionTB.Parent).Parent).BorderBrush = Brushes.Red;
                return false;
            }
            else
            {
                ((Border)((DockPanel)editionTB.Parent).Parent).BorderBrush = Brushes.Black;
            }
            int number;
            if(!int.TryParse(numberTB.Text, out number) || numberTB.Text.Length > 4)
            {
                ((Border)((DockPanel)numberTB.Parent).Parent).BorderBrush = Brushes.Red;
                return false;
            }
            else
            {
                ((Border)((DockPanel)numberTB.Parent).Parent).BorderBrush = Brushes.Black;
            }
            int numberOfPages;
            if (!int.TryParse(NoPTB.Text, out numberOfPages) || NoPTB.Text.Length > 4)
            {
                ((Border)((DockPanel)NoPTB.Parent).Parent).BorderBrush = Brushes.Red;
                return false;
            }
            else 
            {
                ((Border)((DockPanel)NoPTB.Parent).Parent).BorderBrush = Brushes.Black;
            }
            decimal price;
            if (!Decimal.TryParse(priceTB.Text, out price) || priceTB.Text.Length > 4)
            {
                ((Border)((DockPanel)priceTB.Parent).Parent).BorderBrush = Brushes.Red;
                return false;
            }
            else
            {
                ((Border)((DockPanel)priceTB.Parent).Parent).BorderBrush = Brushes.Black;
            }
            return true;
        }

        private void BuyB_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Border)sender).Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            ((TextBlock)((Border)sender).Child).Foreground = new SolidColorBrush(Color.FromRgb(1, 52, 64));
        }

        private void BuyB_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Border)sender).Background = new SolidColorBrush(Color.FromRgb(1, 52, 64));
            ((TextBlock)((Border)sender).Child).Foreground = Brushes.White;
        }

        private void BuyB_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (((ListBox)((Border)((Grid)((Border)sender).Parent).Parent).Parent).Name == AddLB.Name)
            {
                Border border = (Border)((Grid)((Border)sender).Parent).Parent;
                if (Convert.ToInt32(((TextBlock)((Grid)border.Child).Children[0]).Text) <= 1)
                {
                    if (OrderLB.Items.Count != 0)
                    {
                        foreach (Border item in OrderLB.Items)
                        {
                            if (((TextBlock)((Grid)item.Child).Children[1]).Text == ((TextBlock)((Grid)border.Child).Children[1]).Text && ((TextBlock)((Grid)item.Child).Children[2]).Text == ((TextBlock)((Grid)border.Child).Children[2]).Text && ((TextBlock)((Grid)item.Child).Children[3]).Text == ((TextBlock)((Grid)border.Child).Children[3]).Text && ((TextBlock)((Grid)item.Child).Children[4]).Text == ((TextBlock)((Grid)border.Child).Children[4]).Text && ((TextBlock)((Grid)item.Child).Children[5]).Text == ((TextBlock)((Grid)border.Child).Children[5]).Text)
                            {
                                AddLB.Items.Remove(border);
                                ((TextBlock)((Grid)item.Child).Children[0]).Text = (Convert.ToInt32(((TextBlock)((Grid)item.Child).Children[0]).Text) + 1).ToString();
                                isInList1 = true;
                                break;
                            }
                            else
                            {
                                isInList1 = false;
                            }
                        }
                        if (!isInList1)
                        {
                            AddLB.Items.Remove(border);
                            ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Back to store";
                            OrderLB.Items.Add(border);
                        }
                    }
                    else
                    {
                        AddLB.Items.Remove(border);
                        ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Back to store";
                        OrderLB.Items.Add(border);

                    }
                }
                else
                {
                    ((TextBlock)((Grid)border.Child).Children[0]).Text = (Convert.ToInt32(((TextBlock)((Grid)border.Child).Children[0]).Text) - 1).ToString();
                    if (OrderLB.Items.Count != 0)
                    {
                        foreach (Border item in OrderLB.Items)
                        {
                            if(((TextBlock)((Grid)item.Child).Children[1]).Text == ((TextBlock)((Grid)border.Child).Children[1]).Text && ((TextBlock)((Grid)item.Child).Children[2]).Text == ((TextBlock)((Grid)border.Child).Children[2]).Text && ((TextBlock)((Grid)item.Child).Children[3]).Text == ((TextBlock)((Grid)border.Child).Children[3]).Text && ((TextBlock)((Grid)item.Child).Children[4]).Text == ((TextBlock)((Grid)border.Child).Children[4]).Text && ((TextBlock)((Grid)item.Child).Children[5]).Text == ((TextBlock)((Grid)border.Child).Children[5]).Text)
                            {
                                ((TextBlock)((Grid)item.Child).Children[0]).Text = (Convert.ToInt32(((TextBlock)((Grid)item.Child).Children[0]).Text) + 1).ToString();
                                isInList1 = true;
                                break;
                            }
                            else
                            {
                                isInList1 = false;
                            }
                        }
                        if(!isInList1)
                        {
                            ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Back to store";
                            OrderLB.Items.Add(newBorder(border));
                            ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Buy";
                        }
                    }
                    else 
                    {
                        ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Back to store";
                        OrderLB.Items.Add(newBorder(border));
                        ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Buy";

                    }
                }
            }
            else if (((ListBox)((Border)((Grid)((Border)sender).Parent).Parent).Parent).Name == OrderLB.Name)
            {
                Border border = (Border)((Grid)((Border)sender).Parent).Parent;
                if (Convert.ToInt32(((TextBlock)((Grid)border.Child).Children[0]).Text) <= 1)
                {
                    if (AddLB.Items.Count != 0)
                    {
                        foreach (Border item in AddLB.Items)
                        {
                            if (((TextBlock)((Grid)item.Child).Children[1]).Text == ((TextBlock)((Grid)border.Child).Children[1]).Text && ((TextBlock)((Grid)item.Child).Children[2]).Text == ((TextBlock)((Grid)border.Child).Children[2]).Text && ((TextBlock)((Grid)item.Child).Children[3]).Text == ((TextBlock)((Grid)border.Child).Children[3]).Text && ((TextBlock)((Grid)item.Child).Children[4]).Text == ((TextBlock)((Grid)border.Child).Children[4]).Text && ((TextBlock)((Grid)item.Child).Children[5]).Text == ((TextBlock)((Grid)border.Child).Children[5]).Text)
                            {
                                OrderLB.Items.Remove(border);
                                ((TextBlock)((Grid)item.Child).Children[0]).Text = (Convert.ToInt32(((TextBlock)((Grid)item.Child).Children[0]).Text) + 1).ToString();
                                isInList1 = true;
                                break;
                            }
                            else
                            {
                                isInList1 = false;
                            }
                        }
                        if (!isInList1)
                        {
                            OrderLB.Items.Remove(border);
                            ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Buy";
                            AddLB.Items.Add(border);
                        }
                    }
                    else
                    {
                        OrderLB.Items.Remove(border);
                        ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Buy";
                        AddLB.Items.Add(border);

                    }
                }
                else
                {
                    ((TextBlock)((Grid)border.Child).Children[0]).Text = (Convert.ToInt32(((TextBlock)((Grid)border.Child).Children[0]).Text) - 1).ToString();
                    if (AddLB.Items.Count != 0)
                    {
                        foreach (Border item in AddLB.Items)
                        {
                            if (((TextBlock)((Grid)item.Child).Children[1]).Text == ((TextBlock)((Grid)border.Child).Children[1]).Text && ((TextBlock)((Grid)item.Child).Children[2]).Text == ((TextBlock)((Grid)border.Child).Children[2]).Text && ((TextBlock)((Grid)item.Child).Children[3]).Text == ((TextBlock)((Grid)border.Child).Children[3]).Text && ((TextBlock)((Grid)item.Child).Children[4]).Text == ((TextBlock)((Grid)border.Child).Children[4]).Text && ((TextBlock)((Grid)item.Child).Children[5]).Text == ((TextBlock)((Grid)border.Child).Children[5]).Text)
                            {
                                ((TextBlock)((Grid)item.Child).Children[0]).Text = (Convert.ToInt32(((TextBlock)((Grid)item.Child).Children[0]).Text) + 1).ToString();
                                isInList1 = true;
                                break;
                            }
                            else
                            {
                                isInList1 = false;
                            }
                        }
                        if (!isInList1)
                        {
                            ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Buy";
                            AddLB.Items.Add(newBorder(border));
                            ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Back to store";
                        }
                    }
                    else
                    {
                        ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Buy";
                        AddLB.Items.Add(newBorder(border));
                        ((TextBlock)((Border)((Grid)border.Child).Children[6]).Child).Text = "Back to store";

                    }
                }
            }

        }

        private void DeleteB_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Border)sender).Background = Brushes.Red;
        }

        private void DeleteB_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Border)sender).Background = Brushes.White;
        }

        private void DeleteB_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (((ListBox)((Border)((Grid)((Border)sender).Parent).Parent).Parent).Name == "AddLB")
            {
                AddLB.Items.Remove((Border)((Grid)((Border)sender).Parent).Parent);
            }
            else if (((ListBox)((Border)((Grid)((Border)sender).Parent).Parent).Parent).Name == "OrderLB")
            {
                OrderLB.Items.Remove((Border)((Grid)((Border)sender).Parent).Parent);
            }
        }
    }
}
