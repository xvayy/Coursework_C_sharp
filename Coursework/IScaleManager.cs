using System;
using System.Collections;
using System.Collections.Generic;

namespace Coursework
{
    public interface IScaleManager : IEnumerable<DigitalScale>
    {
        void AddScale(DigitalScale scale);
        void RemoveScale(int index);
        //void SelectScale(int scaleId);
        int FindScaleIndexById(int id);
        //void EditScaleById(int id, Action<DigitalScale> editAction);
        double CalculateTotalWeighingError();


        void SaveToJson(string path);
        void LoadFromJson(string path);
        void SaveToXml(string path);
        void LoadFromXml(string path);

        // Повертає обрані ваги або null
        DigitalScale? GetSelectedScale();
        List<DigitalScale> GetAllScales();
    }
}