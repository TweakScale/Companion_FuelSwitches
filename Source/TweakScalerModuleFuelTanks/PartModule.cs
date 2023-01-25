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
using KSPe.Annotations;

namespace TweakScaleCompanion.FuelSwitches.ModuleFuelTanks
{
	// This PartModule is needed to undo TweakScale's implementation for IPartMassModifier
	// Nothing else is done here.
	public class TweakScalerModuleFuelTanks : PartModule, IPartMassModifier
	{
		#region Part Module Fields

		/// <summary>
		/// Whether the Helper was deativated by some reason (usually the Sanity Checks)
		/// </summary>
		[KSPField(isPersistant = false)]
		public bool isActive = true;

		#endregion

		private IPartMassModifier modifier = null;

		#region KSP Life Cycle

		public override void OnAwake()
		{
			Log.dbg("OnAwake {0}", this.InstanceID);
			base.OnAwake();
		}

		public override void OnStart(StartState state)
		{
			Log.dbg("OnStart {0} {1}", this.InstanceID, state);
			base.OnStart(state);

			// If the Integrator's DLL was not loaded, we are dead in the water.
			if (!(this.enabled = Startup.OK_TO_GO)) return;

			this.modifier = (IPartMassModifier)this.part.Modules.GetModule<TweakScale.TweakScale>();

			this.enabled = true;
		}

		// Undoes TweakScale GetModuleMass, as ModuleFuelTanks has its own computations.
		float IPartMassModifier.GetModuleMass(float defaultMass, ModifierStagingSituation sit)
		{
			return (null == this.modifier) ? 0f : (-1f * this.modifier.GetModuleMass(defaultMass, sit));
		}

		ModifierChangeWhen IPartMassModifier.GetModuleMassChangeWhen()
		{
			return (null == this.modifier) ? ModifierChangeWhen.FIXED : this.modifier.GetModuleMassChangeWhen();
		}

		#endregion

		private string InstanceID => string.Format("{0}:{1:X}", this.part.name, (null == this.part ? 0 : this.part.GetInstanceID()));
	}
}
