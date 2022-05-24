import ReactApexChart from "react-apexcharts";
import "./CalorieGraph.css";

export default function CalorieGraph() {
  const startDate = new Date("01 May 2022").getTime();
  const endDate = new Date("15 Aug 2022").getTime();
  const minCalories = 1000;

  const goal = {
    value: 2500,
  };

  const data = [
    {
      name: "Calories",
      data: [
        [new Date("01 May 2022").getTime(), 1243],
        [new Date("05 May 2022").getTime(), 1563],
        [new Date("11 May 2022").getTime(), 2627],
        [new Date("17 May 2022").getTime(), 2364],
        [new Date("25 May 2022").getTime(), 2344],
        [new Date("27 May 2022").getTime(), 2322],
        [new Date("30 May 2022").getTime(), 2055],
        [new Date("05 Jun 2022").getTime(), 1744],
        [new Date("10 Jun 2022").getTime(), 3322],
        [new Date("14 Jun 2022").getTime(), 1536],
        [new Date("19 Jun 2022").getTime(), 1723],
        [new Date("25 Jun 2022").getTime(), 2005],
        [new Date("28 Jun 2022").getTime(), 2122],
        [new Date("5  Jul 2022").getTime(), 1678],
        [new Date("13 Jul 2022").getTime(), 1523],
        [new Date("21 Jul 2022").getTime(), 1677],
      ],
    },
  ];

  const options = {
    chart: {
      type: "line",
      zoom: {
        enabled: false,
      },
    },
    dataLabels: {
      enabled: false,
    },
    stroke: {
      curve: "straight",
    },
    title: {
      text: "Personal Calories history",
      align: "left",
    },
    grid: {
      row: {
        colors: ["#f3f3f3", "transparent"], // takes an array which will be repeated on columns
        opacity: 0.5,
      },
    },
    xaxis: {
      type: "datetime",
      min: startDate,
      tickAmount: 6,
      max: endDate,
    },
    yaxis: {
      min: minCalories,
    },
    tooltip: {
      x: {
        format: "dd MMM yyyy",
      },
    },
    annotations: {
      yaxis: [
        {
          y: goal.value,
          borderColor: "#00E396",
          label: {
            borderColor: "#00E396",
            style: {
              color: "#fff",
              background: "#00E396",
            },
            text: "Current Calories goal",
          },
        },
      ],
    },
  };

  return (
    <div className="card WeightGraph">
      <div id="chart">
        <ReactApexChart
          options={options}
          series={data}
          type="line"
          height={500}
        />
      </div>
    </div>
  );
}
