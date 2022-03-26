using System.Windows.Forms;

namespace accounting_property_source.Classes
{
    class ExtraTools
    {
        //Если много TextBox, что бы много раз не прописывать условие, вызывается этот метод и в него передаётся N количество TextBox и внутри цикла идёт проверка
        public bool isTBEmptyOrNull(params TextBox[] items)
        {
            bool result = true;
            foreach (TextBox item in items)
                if (string.IsNullOrEmpty(item.Text))
                    result = false;
            return !result;
        }
        //Очистить разом все TextBox.
        public void ClearTB(params TextBox[] items)
        {
            foreach (TextBox item in items)
                item.Clear();
        }
    }
}
