using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS
        public ProductBL() {
            //
            // instantiate the view model and initialize the data set
            //
            _productWindowPresenter = new ProductWindowPresenter(GetComanptData(), GetProductData());

            //
            // instantiate, set the data context, and show the Main Window
            //
            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }

        private Product GetProductData()
        {
            return new Product()
            {
                Id = 0,
                TypeOfMustard = "Yellow Mustard",
                CompanyName = "Heinz",
                Age = 35,
                Gender = Product.GenderType.male,
                PriceOfProduct = 1.00,
                HireDate = DateTime.Parse("7/7/7"),
                Description = "The most common type of mustard.",
                ImageFileName = "mustard.jpg"
            };
        }

        private Company GetComanptData()
        {
            Company company = new Company();

            company.Name = "Mustard Distribution Agency";
            company.Address = "11 Front Street";
            company.City = "Traverse City";

            return company;
        }
        #endregion

        #region METHODS



        #endregion

        #region EVENTS


        #endregion

    }
}
