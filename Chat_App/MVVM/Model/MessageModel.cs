using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.MVVM.Model
{
    public class MessageModel
    {
        public string Username { get; set; }
        public string UsernameColor { get; set; }
        public string ImageSource { get; set; } = string.Empty;
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsSendByUserName { get; set; }
        public bool? FirstMessage { get; set; }

    }
}
