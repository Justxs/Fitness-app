import ReactApexChart from "react-apexcharts";
import "./WeightGraph.css";

export default function WeightGraph() {
  const startDate = new Date("01 May 2022").getTime();
  const endDate = new Date("15 Aug 2022").getTime();
  const minWeight = 80;

  const goal = {
    value: 83,
    date: new Date("31 Jul 2022").getTime(),
  };

  const data = [
    {
      name: "Weight",
      data: [
        [new Date("01 May 2022").getTime(), 91.3],
        [new Date("05 May 2022").getTime(), 91.1],
        [new Date("11 May 2022").getTime(), 93.2],
        [new Date("17 May 2022").getTime(), 92.1],
        [new Date("25 May 2022").getTime(), 90.5],
        [new Date("27 May 2022").getTime(), 90.9],
        [new Date("30 May 2022").getTime(), 90.1],
        [new Date("05 Jun 2022").getTime(), 89.3],
        [new Date("10 Jun 2022").getTime(), 89.7],
        [new Date("14 Jun 2022").getTime(), 89.9],
        [new Date("19 Jun 2022").getTime(), 91.0],
        [new Date("25 Jun 2022").getTime(), 89.3],
        [new Date("28 Jun 2022").getTime(), 88.5],
        [new Date("5  Jul 2022").getTime(), 87.7],
        [new Date("13 Jul 2022").getTime(), 86.9],
        [new Date("21 Jul 2022").getTime(), 85.3],
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
      text: "Personal weight history",
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
      min: minWeight,
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
            text: "Current weight loss goal",
          },
        },
      ],
      xaxis: [
        {
          x: goal.date,
          borderColor: "#00E396",
          label: {
            borderColor: "#00E396",
            style: {
              color: "#fff",
              background: "#00E396",
            },
            text: "Current weight loss goal date",
          },
        },
      ],
    },
  };

  return (
    <div className="card weightGraph">
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
