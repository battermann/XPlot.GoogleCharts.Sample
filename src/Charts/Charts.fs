namespace Charts

module BarCharts =
    open XPlot.GoogleCharts

    let statusCount () =

        let series = [("Open",23); ("In Progress",5); ("Resolved", 58); ("Closed",5)]

        let options =
            Options(
                title = "Status", 
                orientation = "horizontal")

        if series |> Seq.isEmpty then "no data" else
            let chart = 
                series
                |> Chart.Bar
                |> Chart.WithOptions options
                |> Chart.WithLabels ["Count"]

            chart.InlineHtml