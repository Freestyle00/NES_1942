namespace NES_1942.Screens
{
    public partial class Germany_from_above
    {

        void CustomInitialize()
        {
            Map.Velocity.Y = -30; //always 30 only more for debug TODO remove magic numbers at end of development
        }

        void CustomActivity(bool firstTimeCalled)
        {
            mapscroll();
        }

        void CustomDestroy()
        {

        }

        static void CustomLoadStaticContent(string contentManagerName)
        {


        }
        void mapscroll()
        {
            if (Map.Y < 500)
            {
                Map.Y = 3400;
            }
        }
    }
}