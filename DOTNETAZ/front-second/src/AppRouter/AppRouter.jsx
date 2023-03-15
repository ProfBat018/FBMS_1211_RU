import App from "../App";

const AppRoutes = [
    {
        index: true,
        element: <App/>
    },
    {
        path: '/themes',
        element: <App/>
    },
    {
        path: '/chapters',
        element: <App />
    }
];

export default AppRoutes;