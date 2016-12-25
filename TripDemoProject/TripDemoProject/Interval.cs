namespace TripBuilding
{
    /// <summary>
    /// Отрезок путешествия
    /// </summary>
    public struct Interval
    {
        /// <summary>
        /// Пункт отправления
        /// </summary>
        public string From
        {
            get
            {
                return from;
            }
            set
            {
                from = value.Trim();
            }
        }

        /// <summary>
        /// Пункт назначения
        /// </summary>
        public string To
        {
            get
            {
                return to;
            }
            set
            {
                to = value.Trim();
            }
        }

        private string from;
        private string to;
    }
}
