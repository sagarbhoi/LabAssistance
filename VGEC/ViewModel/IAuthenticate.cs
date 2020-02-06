using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VGEC.Models;

namespace VGEC.ViewModel
{
    public interface IAuthenticate
    {
        void Authenticate(IPerson person);
    }
}