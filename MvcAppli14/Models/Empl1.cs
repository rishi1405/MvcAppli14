using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using MvcAppli14.Common;

namespace MvcAppli14.Models
{
    [MetadataType(typeof(EmplMetaData))]
    public partial class Empl
    {
    }

    public class EmplMetaData
    {
        [RemoteClientServer("IsUserNameAvailable", "Home", 
        ErrorMessage="UserName already in use")]
        public string FirstName { get; set; }
    }
}