/*
	This file is part of TweakScalerModuleFuelTanksRescalable, a component of TweakScaleCompanion_FuelSwitches
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
using System;

using TweakScale;
using MFT = RealFuels.Tanks.ModuleFuelTanks;

namespace TweakScaleCompanion.FuelSwitches.ModuleFuelTanks
{
	// Modular Fuel Tanks and Real Fuels share the same codebase (and namespaces), what a mess!
	public class Rescalable : IRescalable
	{
		private readonly Part part;
		private readonly MFT module;

		public Rescalable(Part part )
		{
			this.part = part;
			this.module = this.part.Modules.GetModule<MFT>();
		}

		void IRescalable.OnRescale(ScalingFactor factor)
		{
			try
			{
				double oldVol = (double)this.module.totalVolume * 0.001d;
				BaseEventDetails data = new BaseEventDetails(BaseEventDetails.Sender.USER);
				data.Set<string>("volName", "Tankage");
				data.Set<double>("newTotalVolume", oldVol * factor.absolute.cubic);
				part.SendEvent("OnPartVolumeChanged", data, 0);
			}
			catch (Exception e)
			{
				Log.error(e, "Exception during MFT interaction" + e.Message);
			}
		}
	}
}
