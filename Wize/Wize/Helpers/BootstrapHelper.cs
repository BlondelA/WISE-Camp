//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Wize.Helpers
//{
//    public static class BootstrapHelper
//    {
//        public static IHtmlString BootstrapListBoxFor<TModel, TProp>(this HtmlHelper<TModel> helper,
//            Expression<Func<TModel, TProp>> property, IEnumerable<SelectListItem> selectList)
//            => helper.ListBoxFor(property, selectList, new { @class = "form-control" });

//        public static IHtmlString BootstrapListBox(this HtmlHelper helper, string propertyName,
//            IEnumerable<SelectListItem> selectList)
//            => helper.ListBox(propertyName, selectList, new { @class = "form-control" });

//        public static IHtmlString BootstrapTextBoxFor<TModel, TProp>(this HtmlHelper<TModel> helper,
//            Expression<Func<TModel, TProp>> property, object value)
//            => helper.TextBoxFor(property,
//                new
//                {
//                    @class = "form-control",
//                    placeholder = helper.ViewData.ModelMetadata.Watermark
//                });

//        public static IHtmlString BootstrapTextBox(this HtmlHelper helper, string propertyName, object value)
//            => helper.TextBox(propertyName, value,
//                new
//                {
//                    @class = "form-control",
//                    placeholder = helper.ViewData.ModelMetadata.Watermark,
//                    //autocomplete = "off"
//                });

//        public static IHtmlString BootstrapValidationFor<TModel, TProp>(this HtmlHelper<TModel> helper,
//            Expression<Func<TModel, TProp>> property)
//            => helper.ValidationMessageFor(property, null, new { @class = "text-danger" });

//        public static IHtmlString BootstrapValidation(this HtmlHelper helper, string propertyName)
//            => helper.ValidationMessage(propertyName, null, new { @class = "text-danger" });
//    }
//}
