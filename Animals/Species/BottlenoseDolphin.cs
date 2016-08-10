namespace Zoolandia.Animals 
{
    public class BottlenoseDolphin : Tursiops
    {
        public BottlenoseDolphin(string name) : base(name)
        {
            this.ScienceName = "Tursiops Truncatus";
            this.CommonName = "Bottlenose Dolphin"; 
        }
        public int Pod {get;set;}
        public override string Movement()
        {
            return "Can't " + base.Movement() + ", but definitely swim.";
        }
        public override float Speed()
        {
            return 12;
        }
    }
}