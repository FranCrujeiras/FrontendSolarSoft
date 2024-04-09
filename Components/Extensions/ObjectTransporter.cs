namespace FrontBlazor.Components.Extensions
{
    public class ObjectTransporter
    {
        public Dictionary<int, object> StoredData = new();

        public void AddData(object target)
        {
            StoredData.Add(target.GetHashCode(), target);
        }

        public object RetrieveData(int key, bool dispose)
        {
            var data = StoredData[key];
            if (dispose)
            {
                StoredData.Remove(key);
            }
            return data;
        }
    }
}
