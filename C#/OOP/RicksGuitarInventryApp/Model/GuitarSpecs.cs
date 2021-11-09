using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksGuitarInventryApp.Model
{
    class GuitarSpecs : Guitar
    {
        string _builder, _model, _type, _backWood, _topWood;
        public GuitarSpecs(GuitarBuilder builder, string model, GuitarType type, Wood backWood, Wood topWood)
        {
            _builder = builder.ToString();
            _model = model.ToLower();
            _type = type.ToString();
            _backWood = backWood.ToString();
            _topWood = topWood.ToString();
        }

        public string Builder
        {
            get => _builder;
        }
        public string Model
        {
            get => _model;
        }
        public string GType
        {
            get => _type;
        }
        public string BackWood
        {
            get => _backWood;
        }
        public string TopWood
        {
            get => _topWood;
        }
    }
}
