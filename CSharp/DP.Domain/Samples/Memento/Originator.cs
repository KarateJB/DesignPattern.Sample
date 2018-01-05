namespace DP.Domain.Samples.Memento
{
    public class EflowOriginator : IOriginator
    {
        private Eflow _eflow = null;

        public Eflow Eflow
        {
            get { return this._eflow; }
            set { this._eflow = value; }
        }

        /// <summary>
        /// 記錄目前狀態
        /// </summary>
        /// <param name="memento"></param>
        public IMemento CreateMemento()
        {
            IMemento memento = new EflowMemento()
            { 
                Id = System.Guid.NewGuid().ToString(),
                Eflow = (Eflow)this._eflow.Clone()
            };
            return memento;
        }

        /// <summary>
        /// 回存舊的狀態
        /// </summary>
        public void RestoreMemento(IMemento memento)
        {
            this._eflow = (memento as EflowMemento).Eflow;
        }
    }
}