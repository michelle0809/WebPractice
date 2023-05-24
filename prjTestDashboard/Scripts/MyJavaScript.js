function createDoughunt(x, y, canvas_id) {
    var doughnutchartCanvas = document.getElementById(canvas_id);
    var doughnutChart = new Chart(doughnutchartCanvas, {
        type: 'doughnut',
        data: {
            labels: x,
            datasets: [{
                data: y,
                borderWidth: 5,
                backgroundColor: ['#D88C9A', '#F2D0A9', '#99C1B9', '#003049'],
                hoverBackgroundColor: ['#D88C9A', '#F2D0A9', '#99C1B9', '#003049']
            }]
        },
        options: {
            responsive: true,
            legend: {
                position: "bottom",
                labels: {
                    boxWidth: 11,
                    fontColor: "#757681",
                    fontSize: 11
                }
            }
        }
    });
};

function createBar(x, y, canvas_id) {
    var doughnutchartCanvas = document.getElementById(canvas_id);

    var doughnutChart = new Chart(doughnutchartCanvas, {
        type: 'bar',
        data: {
            labels: x,
            datasets: [{
                data: y,
                borderWidth: 5,
                backgroundColor: ['#D88C9A', '#F2D0A9', '#99C1B9', '#003049'],
                hoverBackgroundColor: ['#D88C9A', '#F2D0A9', '#99C1B9', '#003049']
            }]
        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    display: false
                }
            }
        }
    });
};

