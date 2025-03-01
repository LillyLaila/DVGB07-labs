using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab2_DVGB07
{
    public partial class LottoProgram : Form
    {
        private Random random = new Random();

        public LottoProgram()
        {
            InitializeComponent();
        }

        //Knapp för StartaLotto.
        private void ButtonStartLotto(object sender, MouseEventArgs e)
        {
            List<int> inputLottoRad = GetLottoRad(); //Lista som lagrar alla input i lottorad 

            if(inputLottoRad.Count != 7)
            {
                return;
            }

            if (!int.TryParse(antalDrag.Text, out int antalDragningar) || antalDragningar <= 0) //Parsar input (string) från antalDrag textboxen och få ut som int. 
            {
                MessageBox.Show("Ange ett giltigt antal dragningar, mst vara heltal", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }

            int countRad5 = 0;
            int countRad6 = 0;
            int countRad7 = 0;

            //Genererar lottorad, och räknar antal rätt.
            for(int i = 0; i < antalDragningar; i++) {
                List<int> generateLottoRad = GeneratedLottoRad();
                int countLottoRad = inputLottoRad.Intersect(generateLottoRad).Count();
                
                if(countLottoRad == 5)
                {
                    countRad5++;
                }
                else if(countLottoRad == 6) {
                    countRad6++;
                } else if(countLottoRad == 7)
                {
                    countRad7++;
                }
            }
            antalrätt5.Text = countRad5.ToString();
            antalrätt6.Text = countRad6.ToString();
            antalrätt7.Text = countRad7.ToString();
        }

        //Hämtar inmatning av lottoRad. 
        private List<int> GetLottoRad()
        {
            List<int> numbers = new List<int>();
            TextBox[] textBoxes = { rad1, rad2, rad3, rad4, rad5, rad6, rad7 };

            foreach (var tb in textBoxes)
            {
                if (!int.TryParse(tb.Text, out int num) ||  num < 1 || num > 35 || numbers.Contains(num))
                {
                    MessageBox.Show("Ange 7 unika tal mellan 1 och 35", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<int>();
                }
                numbers.Add(num);
            }
            return numbers;
        }

        //Genererar en lottoRad
        private List<int> GeneratedLottoRad()
        {
            HashSet<int> numbers = new HashSet<int>();
            while (numbers.Count < 7)
            {
                numbers.Add(random.Next(1, 36));
            }
            return numbers.ToList();
        }
    }
}

