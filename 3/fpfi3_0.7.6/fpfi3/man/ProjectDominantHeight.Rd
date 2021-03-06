% Generated by roxygen2: do not edit by hand
% Please edit documentation in R/project.R
\name{ProjectDominantHeight}
\alias{ProjectDominantHeight}
\title{Project the Dominant Height}
\usage{
ProjectDominantHeight(species, region, Hd1, Age1, Age2, Alt = 100)
}
\arguments{
\item{species}{A character indicating one of the species name. The function is case insensitive.}

\item{region}{A character indicating one of the region names (depending on the species). The function is case insensitive. Default is NULL.}

\item{Hd1}{Initial Dominant Height.}

\item{Age1}{A scalar numeric indicating the Age at wich \code{Hd1} is measured.}

\item{Age2}{A scalar integer at which the projection is desired.}

\item{Alt}{The altitude in meters. Used by some functions only. Default is 100.}
}
\value{
A scalar numeric.
}
\description{
This function project the dominant height at any desired age, using different parameters and structure
depending on the species and region.
}
\details{
Models were extracted from:
\itemize{
\item Eucalyptus:
\itemize{
\item Uruguay: DSS grandis. Need documentation
}
\item Pinus Radiata:
\itemize{
\item New Zealand: Guy L. Pinjuv 2006, Equation 4.32, Table 4.7. This functions uses an altitude parameter.
}
\item Pinus Taeda:
\itemize{
\item Uruguay: SAG
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
  \code{\link{ProjectNTrees}}, \code{\link{ProjectVolume}},
  \code{\link{SiteIndex}}, \code{\link{availableSpecies}}
}
\author{
Álvaro Paredes, \email{alvaro.paredes@fpfi.cl}
}
\concept{Internals}
