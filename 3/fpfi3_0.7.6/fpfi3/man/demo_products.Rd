% Generated by roxygen2: do not edit by hand
% Please edit documentation in R/data.R
\docType{data}
\name{demo_products}
\alias{demo_products}
\title{Products}
\format{A \code{data.table} with 4 variables:
\itemize{
\item{\code{diamater: }}{Small end diameter in cm.}
\item{\code{length: }}{Log length in meters.}
\item{\code{value: }}{The value (in any currency).}
\item{\code{name: }}{The log name.}
\item{\code{log_type: }}{A character indicating if the log is prunned ('p') or not prunned ('u').}
\item{\code{class: }}{An aggregation name, in case is necessary (for example,
when \code{link[fpfi3]{FullSimulation}} is ran with the options \code{byClass = TRUE}.}
}}
\usage{
demo_products
}
\description{
An example of a set of products.
}
\keyword{internal}
