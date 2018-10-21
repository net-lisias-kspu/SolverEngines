# Solver Engines :: Change Log

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
