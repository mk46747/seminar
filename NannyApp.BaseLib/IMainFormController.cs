﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.Model;
using System.Windows.Forms;

namespace NannyApp.BaseLib
{
    public interface IMainFormController
    {
        void ShowNannyForm(Form LoginView);
        void CreateNanny(INannyView NannyView);
        void ShowLoginForm(IMainView MainView);
        void LoginUser(ILoginView LoginView);
        void ShowMainForm();
        
        void ShowParentForm(Form LoginView);
        void CreateParent(IParentView ParentView);
        void ShowOfferForm();
        void CreateOffer(IOfferView OfferView);
        /*
        void ShowCreateParentOfferForm();
        void CreateParentOffer(ICreateParentOfferView CreateParentOfferView);
        void ShowOffersForm();
        void ShowOfferForm();
        void ShowCooperationsForm();
        void ShowNannyForm();
        void ShowParentForm();
        void ShowCooperationsForm();
        void ShowCooperationForm();
        */
       
    }
}
