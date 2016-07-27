namespace Zoolandia.Species 
{
    public class BottlenoseDolphin : Animal
    {
        public string ScienceName {get;set;}
        public string CommonName {get;set;}
        public BottlenoseDolphin(bool smart, int limbs) : base(smart, limbs)
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