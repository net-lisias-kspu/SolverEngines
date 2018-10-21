# Solver Engines :: Change Log

* 2016-0706: 2.3 (blowfishpro) for KSP 1.1.3
	+ Revert and freeze AssemblyVersion to fix compatibility issues
* 2016-0701: 2.2 (blowfishpro) for KSP 1.1.3
	+ Recompile against KSP 1.1.3
* 2016-0501: 2.1 (NathanKell) for KSP 1.1.2
	+ Recompile for KSP 1.1.2
* 2016-0427: 2.0 (blowfishpro) for KSP 1.1
	+ Changes
		- Updated for KSP 1.1
		- Support variable thrust per transform as in ModuleEngines
* 2016-0201: 1.15 (blowfishpro) for KSP 1.0.4.
	+ Changes:
		- Add some math utils
		- Adjust UpdateFlightCondition to better accommodate simulations
			- NOTE: this change is backwards-incompatible
		- Add a generic animation class
* 2015-1215: 1.14 (blowfishpro) for KSP 1.0.4.
	+ Minor refactor of engine fitting
	+ Get rid of debug spam in non Kerbin/Earth atmospheres
* 2015-1119: 1.13 (NathanKell) for KSP 1.0.4.
	+ Respect the Ignore Max Temp cheat.
* 2015-1116: 1.12 (blowfishpro) for KSP 1.0.4.
	+ Changes
		- Recomile agains 1.0.5
		- Get rid of ModuleAnimateEmissive, now unneded with stock changes
		- Remove engine code now included in stock
			- Remove hacky event replacements
		- Make engine module and solver abstract
		- Allow engine modules to check whether they are underwater
* 2015-0909: 1.11 (NathanKell) for KSP 1.0.4.
	+ Make heat production quadratic with throttle rather than linear.
* 2015-0827: 1.10 (NathanKell) for KSP 1.0.4.
	+ Fix some NREs.
	+ Fix flickering of FX on burnout.
	+ Fix error in speed of sound formula; this fixes AJE propellers (with AJE 2.4+)
	+ Add hook for temperature-based autorestart.
	+ Make displayed actual throttle display two decimal points.
* 2015-0729: 1.9 (NathanKell) for KSP 1.0.4.
	+ Changelog:
		- Prevent flight GUI button from disappearing.
		- Fix flameouts at 0 mass requested.
		- Fix a math bug.
		- Add virtuals vFlameout and vUnflameout if a mod wants to override them.
		- Allow required intake area to be adjusted.
		- Cut TPR if insufficient intake area.
		- Auto-unflameout thanks to nimaroth
		- Fix issue with alternators.
		- Fix an issue with engine fitting.
* 2015-0721: 1.8 (NathanKell) for KSP 1.0.4.
	+ Changelog:
		- Fix for GUI issues in 1.7.
		- To avoid the "can't restart engine once propellant is provided again" issue, shutdown and then activate your engine. That will clear its memory of flameouts.
* 2015-0719: 1.7 (NathanKell) for KSP 1.0.4.
	+ Changelog
		- Remove duplicate GUI entries.
		- Avoid some NREs.
* 2015-0710: 1.6 (NathanKell) for KSP 1.0.4.
	+ Finally fix the "can't start when shielded" thing. Activate/toggle was fixed but staging wasn't.
	+ Improve fitting code.
	+ Fix version file.
* 2015-0704: 1.5 (NathanKell) for KSP 1.0.4.
	+ Changelog:
		- EngineThermodynamics improvements (docs, track mass flow, allow mixing streams).
		- Add functionality to fit an engine's performance parameters to a set of database parameters.
		- Add SFC as a base solver member (in force/weight-hr).
* 2015-0625: 1.4 (NathanKell) for KSP 1.0.4.
	+ Changelog:
		- Update to KSP 1.0.4.
		- Make the "can't start engine in fairing/bay" functionality toggleable ( noShieldedStart in the MODULE), and default to off.
		- Speed things up a little in the GUI/VesselModule
		- Changed GUI namespace to avoid an issue with Toolbar.
* 2015-0615: 1.3 (NathanKell) for KSP 1.0.2
	+ Changelog:
		- Pass velocity as a Vector3d (vel in the solver is still a double).
* 2015-0611: 1.2 (NathanKell) for KSP 1.0.2
	+ Changelog:
		- Made base members of the solver public for accessibility.
		- Added Q (dynamic pressure) as one of the base members.
* 2015-0606: 1.1 (NathanKell) for KSP 1.0.2
	+ Make temperature gauges configurable
	+ Fix for flameout-at-zero-thrust
* 2015-0524: 1.0 (NathanKell) for KSP 1.0.2
	+ Initial release. See readme for details.
