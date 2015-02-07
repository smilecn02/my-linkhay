using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLinkhay.ViewModels
{
    public class DeleteConfirmationViewModel
    {
        public string PostDeleteAction { get; set; }
        public string PostDeleteController { get; set; }
        public int DeleteEntityId { get; set; }
        public string HeaderText { get; set; }
    }
}