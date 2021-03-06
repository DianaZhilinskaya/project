﻿using System.Data.Entity;
using System.Linq;
using System.Windows;
using Database;
using Logics.Services;
using WpfApplication.Helpers;

namespace WpfApplication
{
    public partial class ТоварыWin : Window
    {
        private Товар prod;
        IService<Товар> prodServ = ServiceLocator.GetService<Товар>();

        public ТоварыWin()
        {
            InitializeComponent();
            var autoServ = ServiceLocator.GetService<Товар>();
            using (autoServ.Uow.Db = new АвтозаправкиEntities())
            {
                var услуги = autoServ.ReadAll();
                услуги.ToList().ForEach(c => list_of_products.Items.Add(c));
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            АвтозаправкаWin winTool = new АвтозаправкаWin();
            winTool.Owner = this;
            winTool.Show();
            this.Hide();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ТоварWin winTool = new ТоварWin();
            winTool.Owner = this;
            winTool.Show();
            this.Hide();
        }
        
        private void search_Click(object sender, RoutedEventArgs e)
        {
            var autoServ = ServiceLocator.GetService<Товар>() as ТоварService;
            var n = name_of_product.Text;
            using (autoServ.Uow.Db = new АвтозаправкиEntities())
            {
                var постоянныеклиенты = autoServ.ReadSome(n);
                list_of_products.Items.Clear();
                постоянныеклиенты.ToList().ForEach(c => list_of_products.Items.Add(c));
            }
        }

        private void list_of_productsSelect(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                prod = e.AddedItems[0] as Товар;
                value.Text = prod.стоимость.Value.ToString();
                amount_of_goods.Text = prod.количесвто.Value.ToString();
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            using (prodServ.Uow.Db = new АвтозаправкиEntities())
            {
                var id = (list_of_products.SelectedItem as Товар).код_товара;
                prodServ.Delete(id);
            }
            list_of_products.Items.Remove(list_of_products.SelectedItem);
        }

        private void insert_prod_check(object sender, RoutedEventArgs e)
        {
            var qtyProd = int.Parse(qty.Text);

            if (prod.количесвто < qtyProd)
            {
                MessageBox.Show("Такое количество товаров недоступнo.");
                return;
            }

            var ch = Settings.Check;
            var checkProd = ch.ЧекТовар.SingleOrDefault(t => t.Товар.код_товара == prod.код_товара);

            if (checkProd == null)
            {
                ch.ЧекТовар.Add(new ЧекТовар() {кол_во = qtyProd, Товар = prod, Чек = Settings.Check});
            }
            else
            {
                checkProd.кол_во += qtyProd; //.количесвто.Value;
            }
            
            using (prodServ.Uow.Db = new АвтозаправкиEntities())
            {
                prod.количесвто -= qtyProd;
                prodServ.Save(prod);
            }
        }
    }
}
