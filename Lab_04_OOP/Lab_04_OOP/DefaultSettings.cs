using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Drawing.Color;
using System.Drawing;

namespace Lab_02_OOP
{
    public class AppSettings
    {
        
        private SizeF _sizeF = new SizeF(4F, 12F);
        private Color _color = Color.LightGray;
        private dynamic _clientSize = new System.Drawing.Size(643, 505);
        
        private static AppSettings _appSettings;
        private AppSettings() { }
        
        public static AppSettings GetInstance()
        {
            if (_appSettings == null)
            {
                _appSettings = new AppSettings();
            }
            return _appSettings;
        }

        public void DoSomething(Form1 form)
        {
            form.AutoScaleDimensions = _appSettings._sizeF;
            form.BackColor = _color;
            form.Size = _clientSize;
        }
    }
}