
# Overview

We have implemented eQual on top of DomainPro, resulting in 4.7K C# and 1.0K JavaScript SLoC added to DomainPro. To aid in eQual’s evaluation, we also built a utility totaling an additional 1.0K C# and 0.2K MATLAB SLoC, as detailed in Section 4.2. All source code, including DomainPro, is hosted [here](https://github.com/arman2/equal_public/tree/master/Source%20Code).

Most important folders here are:

  1. Simulation Engine: the core simulation engine which was part of DomainPro.
  2. Analyst: the UI for the DomainPro analyzer. This allow architects using DomainPro to play with a single variant and simulate its behvaior.
  3. CloudController: the eQual engine which is in charge of orchestrating different aspects of simulation, distribution, BRTA, and final visualization.
  4. SimulationService: the service that each node will have to run to be able to complete simulations that are assigned to it.  
