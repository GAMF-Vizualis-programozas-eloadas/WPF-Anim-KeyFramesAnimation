using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace KeyFrames_Animation
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btIndít_Click(object sender, RoutedEventArgs e)
		{
			StringAnimationUsingKeyFrames da = new StringAnimationUsingKeyFrames();
			da.AutoReverse = true;
			double t = 0, dt = 0.25;
			da.KeyFrames.Add(new DiscreteStringKeyFrame("", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("É", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Ér", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Ért", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Érté", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Érték", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Értéks", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Értékso", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.KeyFrames.Add(new DiscreteStringKeyFrame("Értéksor", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(DT(ref t, dt)))));
			da.Duration = new Duration(TimeSpan.FromSeconds(DT(ref t, dt)));
			btIndít.BeginAnimation(ContentProperty, da);
		}
		private double DT(ref double t, double dt)
		{
			t = t + dt;
			return t;
		}

	}
}
