using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HW
{
    static class Program
    {

        static DialogResult ShowMessageBoxes_1()
        {
            //1
            string _message = "Текст сообщения";
            string _caption = "Заголовок сообщения";
            MessageBox.Show(_message, _caption);
            //2
            DialogResult _result = MessageBox.Show(_message, _caption,
               MessageBoxButtons.YesNo);
            //3
            _result = MessageBox.Show(_message);
            return _result;
        }
        static DialogResult ShowMessageBoxes_2()
        {
            string _message = "Сообщение от програмиста";
            MessageBox.Show(_message);
            string _caption = "Это заглавие";
            MessageBox.Show(_message,_caption);
            //2
            _caption = "Выбор";
            DialogResult _result = MessageBox.Show(_message, _caption,
               MessageBoxButtons.YesNoCancel);
            string _button = _result.ToString();
            _result = MessageBox.Show("Вы выбрали " + _button,
            _button, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return _result;

        }
       
        static void Main()
        {
            
                    DialogResult _res;
                    do
                    {
                        _res = ShowMessageBoxes_1();
                    } while (_res == DialogResult.Retry);
                   
                    DialogResult _res2;
                    do
                    {
                        _res2 = ShowMessageBoxes_2();
                    } while (_res2 == DialogResult.Retry);
                  
        
            
        }
    }
}
