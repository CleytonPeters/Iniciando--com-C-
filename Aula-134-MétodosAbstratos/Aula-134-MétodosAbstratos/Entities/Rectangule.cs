using Aula_134_MétodosAbstratos.Entities.Enum;
namespace Aula_134_MétodosAbstratos.Entities
{
    class Rectangule : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangule(double height, double width, Color color) : base(color)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Width * Height;
        }

    }
}
