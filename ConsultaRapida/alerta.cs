using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace ConsultaRapida
{
    class alerta
    {
        public static void popup(string titulo, string mensagem)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.BodyColor = Color.FromArgb(84, 26, 156);
            popup.BorderColor = Color.White;
            popup.ContentColor = Color.White;
            popup.TitleText = titulo;
            popup.TitleColor = Color.White;
            popup.ContentText = mensagem;
            popup.Popup();
        }
    }
}
