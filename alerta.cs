using System;
using Tulpep.NotificationWindow;

public class Class1
{
	public static popup(string titulo, string mensagem)
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
