import './App.css';

import Loading from 'component/Loading';
import MainPage from 'page/MainPage/MainPage';
import { Suspense } from 'react';

function App() {
    return (
        <Suspense fallback={<Loading />}>
            <MainPage />
        </Suspense>
    );
}

export default App;
