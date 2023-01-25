/*
	This file is part of TweakScalerModuleFuelTanks, a component of TweakScaleCompanion_FuelSwitches
	© 2023 LisiasT : http://lisias.net <support@lisias.net>

	TweakScaleCompanion_FuelSwitches is double licensed, as follows:
		* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
		* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

	And you are allowed to choose the License that better suit your needs.

	TweakScaleCompanion_FuelSwitches is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with TweakScaleCompanion_FuelSwitches. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with TweakScaleCompanion_FuelSwitches. If not, see <https://www.gnu.org/licenses/>.

*/
using UnityEngine;
using KSPe.Annotations;

namespace TweakScaleCompanion.FuelSwitches.ModuleFuelTanks
{
	[KSPAddon(KSPAddon.Startup.Instantly, true)]
	public class Startup : MonoBehaviour
	{
		internal const string TARGET_MODULE_NAME = "ModuleFuelTanks";
		internal const string MFT_ASSEMBLY_NAME = "ModularFuelTanks";
		internal const string RF_ASSEMBLY_NAME = "RealFuels";
		internal const string SCALER_MODULE_NAME = "TweakScalerModuleFuelTanksRescalable";

		internal static bool OK_TO_GO = false;	// If we can't load the Integrator, there's no point on dry running the PartModule...

		[UsedImplicitly]
		private void Awake()
		{
			using(KSPe.Util.SystemTools.Assembly.Loader a = new KSPe.Util.SystemTools.Assembly.Loader(typeof(TweakScaleCompanion.FuelSwitches.Startup).Namespace.Replace(".",KSPe.IO.Path.DirectorySeparatorStr)))
			{ 
				OK_TO_GO = true;
				if (KSPe.Util.SystemTools.Assembly.Finder.ExistsByName(MFT_ASSEMBLY_NAME))
					a.LoadAndStartup("TweakScalerModuleFuelTanksRescalable");
				else if (KSPe.Util.SystemTools.Assembly.Finder.ExistsByName(RF_ASSEMBLY_NAME))
					a.LoadAndStartup("TweakScalerRealFuelsRescalable");
				else
					OK_TO_GO = false;
			}
		}
	}
}
