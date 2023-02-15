using Chat_App.Core;
using Chat_App.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Chat_App.MVVM.View_Model
{
    public class MainWindowVM:ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        //Commands//
        public RelayCommand SendCommand { get; set; }


        //Viewing messages based on the selected contact
        private ContactModel _selectedContact;
        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set { 
                _selectedContact = value; 
                OnPropertyChanged();
            }
        }

        public string _message { get; set; }
        public string Message
        {
            get { return _message; }
            set 
            { 
                _message = value;
                OnPropertyChanged();
            }
        }

        //Constructor
        public MainWindowVM()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();
            SendCommand = new RelayCommand(i =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });

                Message = "";
            });

            //Seeding test data
            Messages.Add(new MessageModel
            {
                Username = "Yasin",
                UsernameColor = "#409aff",
                ImageSource = "https://marketplace.canva.com/EAFEits4-uw/1/0/1600w/canva-boy-cartoon-gamer-animated-twitch-profile-photo-oEqs2yqaL8s.jpg",
                Message = "Hello, how are you?",
                SendDate = DateTime.UtcNow,
                IsSendByUserName = false,
                FirstMessage = true
            });

            for(int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Habib",
                    UsernameColor = "#409aff",
                    ImageSource = "https://marketplace.canva.com/EAFEits4-uw/1/0/1600w/canva-boy-cartoon-gamer-animated-twitch-profile-photo-oEqs2yqaL8s.jpg",
                    Message = "Test Message",
                    SendDate = DateTime.UtcNow,
                    IsSendByUserName = true,
                });
            }

            Messages.Add(new MessageModel
            {
                Username = "Habib",
                UsernameColor = "#409aff",
                ImageSource = "https://marketplace.canva.com/EAFEits4-uw/1/0/1600w/canva-boy-cartoon-gamer-animated-twitch-profile-photo-oEqs2yqaL8s.jpg",
                Message = "Test Message",
                SendDate = DateTime.UtcNow,
                IsSendByUserName = true,
            });

            //Creating contacts data
            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Yasin {i}",
                    ImageSource = "https://marketplace.canva.com/EAFEits4-uw/1/0/1600w/canva-boy-cartoon-gamer-animated-twitch-profile-photo-oEqs2yqaL8s.jpg",
                    Messages = Messages
                });
            }
        }

    }
}
