% Generated by roxygen2: do not edit by hand
% Please edit documentation in R/project.R
\name{ProjectNTrees}
\alias{ProjectNTrees}
\title{Project the number of trees.}
\usage{
ProjectNTrees(species, region, N0, BA1, Age1, Age2, SI)
}
\arguments{
\item{species}{A character indicating one of the species name. The function is case insensitive.}

\item{region}{A character indicating one of the region names (depending on the species). The function is case insensitive. Default is NULL.}

\item{N0}{A scalar indicating the initial number of trees.}

\item{BA1}{A scalar numeric indicating the initial BA.}

\item{Age1}{A scalar numeric indicating the Age at wich \code{N0} is measured.}

\item{Age2}{A scalar integer at which the projection is desired.}

\item{SI}{A scalar numeric indicating the Site Index.}
}
\value{
A scalar numeric.
}
\description{
This function project the number of trees at any desired age, using different parameters and structure
depending on the species and region.
}
\details{
Models were extracted from:
\itemize{
\item Eucalyptus:
\itemize{
\item Uruguay: document
}
\item Pinus Radiata:
\itemize{
\item New Zealand: document
}
\item Pinus Taeda:
\itemize{
\item Uruguay: document
}
}
}
\examples{
1+1
}
\seealso{
Other Internals: \code{\link{Dispatcher}},
  \code{\link{EstimateDBHSd}},
  \code{\link{GetBAAfterThinning}},
  \code{\link{ProjectBasalArea}},
  \code{\link{ProjectDominantHeight}},
  \code{\link{ProjectVolume}}, \code{\link{SiteIndex}},
  \code{\link{availableSpecies}}
}
\author{
Álvaro Paredes, \email{alvaro.paredes@fpfi.cl}
}
\concept{Internals}
