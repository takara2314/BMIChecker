using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMIChecker {
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Done_Click(object sender, RoutedEventArgs e) {
			double height = double.Parse(height_box.Text) / 100;
			double weight = double.Parse(weight_box.Text);
			double BMI = weight / (height * height);
			// 四捨五入
			BMI_block.Text = "BMI：" + Math.Round(BMI * 100) / 100;
			if (BMI < 19.8 || BMI >= 24.2) {
				result_block.Text = "不健康";
			}
			else
				result_block.Text = "";
		}
	}
}
