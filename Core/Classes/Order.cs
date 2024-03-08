using System;

namespace Core.Classes
{
    public class Order : StandardTable
    {
        private int client_id;
        private int number;
        private string mark;
        private DateTime record_date;
        private float total_price;

        public int ClientId
        {
            get => client_id;
            set => client_id = value;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public string Mark
        {
            get => mark;
            set => mark = value;
        }

        public DateTime RecordDate
        {
            get => record_date;
            set => record_date = value;
        }

        public Order(string mark, int number)
        {
            this.mark = mark;
            this.number = number;
        }

        public Order()
        {
            
        }

        public override string ToString()
        {
            return $"Order : client id = {client_id}, number = {number}, mark = {mark}, record date = {record_date}";
        }
    }
}