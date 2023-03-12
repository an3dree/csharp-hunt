using System;

namespace FirstClass
{
    public class Message
    {
        private string TextMessage;

        public void ShowMessage()
        {
            Console.WriteLine(this.TextMessage);
        }

        public String getMessage()
        {
            return this.TextMessage;
        }

        public void setMessage(String newText)
        {
            this.TextMessage = newText;
        }

        // outro meio de encapsular propriedades
        private String titleMessage;
        public String TitleMessage
        {
            get
            {
                return this.titleMessage;
            }
            set
            {
                this.titleMessage = value;
            }
        }
        public void ShowMessageTitle()
        {
            Console.WriteLine(this.titleMessage);
        }
    }
}