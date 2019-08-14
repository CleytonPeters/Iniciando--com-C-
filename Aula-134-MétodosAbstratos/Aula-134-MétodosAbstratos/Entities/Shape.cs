using Aula_134_MétodosAbstratos.Entities.Enum;

namespace Aula_134_MétodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {

        }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
