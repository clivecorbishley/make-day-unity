using System;
using System.Collections.ObjectModel;

namespace Application
{
    public class SingleStateManager : DefaultTrackableEventHandler
    {
        protected override void OnTrackingFound()
        {

            // run the base code
            base.OnTrackingFound();
            string trackableObject = mTrackableBehaviour.TrackableName;
            Cards cards = new Cards();
            switch (trackableObject.ToLower()){
                case "offerzen_gitdog":
                case "offerzen_merpug":
                    cards = new Dog();
                    break;
                case "offerzen_mew_mew":
                    cards = new Cat();
                    break;
                case "offerzen_badass_unicorn":
                    cards = new Unicorn();
                    break;
                case "egg_blue":
                    cards = new Egg();
                    break;
                case "drone":
                    cards = new Drone();
                    break;
                case "oxygen":
                    cards = new Plant();
                    break;
                case "offerzen_astrosloth":
                    cards = new Sloth();
                    break;
                default:
                    break;

            }

              

            // then your own sh*z

            LessThan.LT.score += cards.Value();
            LessThan.LT.stuff.Add(cards);
            print("Values now at: " + LessThan.LT.score);
        }

        protected override void OnTrackingLost()
        {
            base.OnTrackingLost();
            string trackableObject = mTrackableBehaviour.TrackableName;
            Cards something = new Cards();
            switch (trackableObject.ToLower())
            {
                case "offerzen_gitdog":
                case "offerzen_merpug":
                    something = new Dog();
                    break;
                case "offerzen_mew_mew":
                    something = new Cat();
                    break;
                case "offerzen_badass_unicorn":
                    something = new Unicorn();
                    break;
                case "egg_blue":
                    something = new Egg();
                    break;
                case "drone":
                    something = new Drone();
                    break;
                case "oxygen":
                    something = new Plant();
                    break;
                case "offerzen_astrosloth":
                    something = new Sloth();
                    break;
                default:
                    break;

            }

            // then your own sh*z
            print("We are the Kings :)");
            print("Size of list: " + cards.Count);

            LessThan.LT.score -= something.Value();

            foreach LessThan.LT.stuff

            print("Values now at: " + LessThan.LT.score);
        }


    }
}
