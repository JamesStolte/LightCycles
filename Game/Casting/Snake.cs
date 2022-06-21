using System;
namespace Tron
{
    public class Bike : Actor
    {
        private List<Actor> segments = new List<Actor>();
        public Bike()
        {
            PrepareTrail();
        }

        /// <summary>
        /// Gets the bikes's trail.
        /// </summary>
        /// <returns>The body segments in a List.</returns>
        public List<Actor> GetTrail()
        {
            return new List<Actor>(segments.Skip(1).ToArray());
        }

        /// <summary>
        /// Gets the bike.
        /// </summary>
        /// <returns>The head segment as an instance of Actor.</returns>
        public Actor GetBike()
        {
            return segments[0];
        }

        /// <summary>
        /// Gets the important points (including the bike and trail).
        /// </summary>
        /// <returns>A list of bike and trail as instances of Actors.</returns>
        public List<Actor> GetSegments()
        {
            return segments;
        }

        /// <summary>
        /// Grows the bike's trail by the given number of segments.
        /// </summary>
        /// <param name="numberOfSegments">The number of segments to grow.</param>
        public void GrowTrail(int numberOfSegments)
        {
            for (int i = 0; i < numberOfSegments; i++)
            {
                Actor trail = segments.Last<Actor>();
                Point velocity = trail.GetVelocity();
                Point offset = velocity.Reverse();
                Point position = trail.GetPosition().Add(offset);

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText("#");
                segment.SetColor(Constants.GREEN);
                segments.Add(segment);
            }
        }

        /// <inheritdoc/>
        public override void MoveNext()
        {
            foreach (Actor segment in segments)
            {
                segment.MoveNext();
            }

            for (int i = segments.Count - 1; i > 0; i--)
            {
                Actor trailing = segments[i];
                Actor previous = segments[i - 1];
                Point velocity = previous.GetVelocity();
                trailing.SetVelocity(velocity);
            }
        }

        /// <summary>
        /// Turns the bike in the given direction.
        /// </summary>
        /// <param name="velocity">The given direction.</param>
        public void TurnBike(Point direction)
        {
            segments[0].SetVelocity(direction);
        }

        /// <summary>
        /// Prepares the bike trail for moving.
        /// </summary>
        private void PrepareTrail()
        {
            int x = Constants.MAX_X / 2;
            int y = Constants.MAX_Y / 2;

            for (int i = 0; i < Constants.TRAIL_LENGTH; i++)
            {
                Point position = new Point(x - i * Constants.CELL_SIZE, y);
                Point velocity = new Point(1 * Constants.CELL_SIZE, 0);
                string text = i == 0 ? "8" : "#";
                Color color = i == 0 ? Constants.YELLOW : Constants.GREEN;

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText(text);
                segment.SetColor(color);
                segments.Add(segment);
            }
        }
    }
}