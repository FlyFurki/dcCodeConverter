using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dccodeconvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        



        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;

            if (radioButton1.Checked == true)
            {
                textBox2.Text = "```html" + code + "```";

            }
            else if(radioButton2.Checked == true)
            {
                textBox2.Text = "```css" + code + "```";

            }
            else if (radioButton3.Checked == true)
            {
                textBox2.Text = "``js" + code + "```";

            }
            else if (radioButton4.Checked == true)
            {
                textBox2.Text = "```c" + code + "```";

            }
            else if (radioButton5.Checked == true)
            {
                textBox2.Text = "```cpp" + code + "```";

            }
            else if (radioButton6.Checked == true)
            {
                textBox2.Text = "```cs" + code + "```";


            }
            else if (radioButton7.Checked == true)
            {
                textBox2.Text = "```java" + code + "```";

            }
            else if (radioButton8.Checked == true)
            {
                textBox2.Text = "```py" + code + "```";

            }
            else if (radioButton9.Checked == true)
            {
                textBox2.Text = "```php" + code + "```";

            }
            else
            {
                MessageBox.Show("Lütfen bir dil seçin");
            }

        }
    }
}
