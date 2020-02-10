using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDEvoGenetic
{
    class GeneticAlgorithm
    {
        public class GeneticAlgorithm<TChromosome, TIndividual, TParentsPair> :
        XGeneticAlgorithm<TChromosome, TIndividual>
        where TIndividual : XIndividual<TChromosome>
        where TParentsPair : XParentsPair<TIndividual>
        {

            public XReproductionStrategy<TIndividual> Strategy { get; protected set; }

            public XPopulationInitializer<TChromosome> PopulationInitializer { get; protected set; }

            public XContinueCondition<TIndividual> ContinueCondition { get; protected set; }

            public XIndividualFactory<TChromosome, TIndividual> IndividualFactory { get; protected set; }

            public XBreeding<TIndividual, TParentsPair> Breeding { get; protected set; }

            public XCrossover<TChromosome, TParentsPair> Crossover { get; protected set; }

            public XMutation<TChromosome> Mutation { get; protected set; }

            public GeneticAlgorithm(
                XReproductionStrategy<TIndividual> strategy,
                XPopulationInitializer<TChromosome> populationInitializer,
                XContinueCondition<TIndividual> continueCondition,
                XIndividualFactory<TChromosome, TIndividual> individualFactory,
                XBreeding<TIndividual, TParentsPair> breeding,
                XCrossover<TChromosome, TParentsPair> crossover,
                XMutation<TChromosome> mutation
                )
            {
                Strategy = strategy;
                PopulationInitializer = populationInitializer;
                ContinueCondition = continueCondition;
                IndividualFactory = individualFactory;
                Breeding = breeding;
                Crossover = crossover;
                Mutation = mutation;
            }

            #region XGeneticAlgorithm<TChromosome,TIndividual,TFitnessFunction> Members

            public TIndividual Run(XFitnessFunction<TChromosome> fitnessFunction)
            {
                int generation = 0;

                var reproductionGroup = new List<TIndividual>();

                var currentPopulationsChromosomes = PopulationInitializer.Initialize();

                IReadOnlyList<TIndividual> currentPopulation = currentPopulationsChromosomes.Select(
                    chromosome => IndividualFactory.CreateIndividual(chromosome, fitnessFunction)
                    ).ToList();

                var bestSolution = currentPopulation[0];

                foreach (var individual in currentPopulation)
                    if (individual.Fitness > bestSolution.Fitness)
                        bestSolution = individual;

                while (ContinueCondition.ShouldContinue(currentPopulation, generation))
                {

                    var pairs = Breeding.Select(currentPopulation);

                    reproductionGroup.Clear();

                    foreach (var Compound in pairs.Select(pair => Crossover.Crossover(pair)))
                    {
                        reproductionGroup.AddRange(
                            Compound
                                .Select(chromosome => Mutation.Mutate(chromosome))
                                .Select(mutant => IndividualFactory.CreateIndividual(mutant, fitnessFunction)));
                    }

                    foreach (var individual in reproductionGroup)
                        if (individual.Fitness > bestSolution.Fitness)
                            bestSolution = individual;

                    currentPopulation = Strategy.NextGeneration(
                        currentPopulation,
                        reproductionGroup
                        );

                    generation++;
                }

                return bestSolution;
            }

            #endregion
        }
    }

}

