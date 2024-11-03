using System.Xml.Linq;

namespace ExpenseCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        { }
        private decimal total_exp = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ExpensesName.Text) || CategoryName.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = ExpensesName.Text;
            string category = CategoryName.SelectedItem?.ToString();
            decimal amount = ExpensesSum.Value;

            MessageBox.Show($"Расходы добавлены:{name},\nСумма{amount}: \nКатегория: {category}\n", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            total_exp += amount;
            TotalExpenses.Text = $"Общая сумма расходов: {total_exp}";
        }
        private void ExpensesName_TextChanged(object sender, EventArgs e)
        {}
        private void ExpensesSum_ValueChanged(object sender, EventArgs e)
        {}
        private void CategoryName_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void TotalExpenses_Click(object sender, EventArgs e)
        { }
        private void TimerLabel_Click(object sender, EventArgs e)
        { }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = $"Время: {DateTime.Now:HH:mm:ss}";
        }

       
    }
}
