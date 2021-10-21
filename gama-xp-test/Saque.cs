using System;
namespace gama_xp_test
{
    public class Saque
    {
        public int id { get; set; }

        public DateTime transactionTime = DateTime.Now;

        public double _value { get; set; }

        public Saque(double value)
        {
            _value = value;
            realizarSaque(value);
        }

        public void salvar()
        {
            Console.WriteLine($"Transacao feita em: {transactionTime} de valor {_value} salva com sucesso!");
        }

        public void realizarSaque(double _withdrawValue)
        {
            double withdrawValue = _withdrawValue;
            BankNote currentNote = BankNote.Cem;
            int bankNotesQuantity = 0;

            while (true)
            {
                if (withdrawValue >= (int)currentNote)
                {
                    withdrawValue -= (int)currentNote;
                    bankNotesQuantity += 1;
                    Console.WriteLine($"Nota de R$ {(int)currentNote} requerida");
                }
                else
                {
                    bankNotesQuantity = 0;
                    int notePrevIndex = Array.IndexOf(Enum.GetValues(currentNote.GetType()), currentNote);
                    notePrevIndex -= 1;
                    currentNote = (BankNote)(Enum.GetValues(currentNote.GetType())).GetValue(notePrevIndex);
                }


                if(withdrawValue == 0 || withdrawValue < 5)
                {
                    break;
                }
            }
        }

    }
}
