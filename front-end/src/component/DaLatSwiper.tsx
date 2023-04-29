import 'swiper/css';
import './style/dalat-swiper.scss';

import PropTypes from 'prop-types';
import React from 'react';
import { Swiper, SwiperProps, SwiperSlide } from 'swiper/react';

const TypeViewRender = {
    mobile: 'mobile',
    ipad: 'ipad',
    laptop: 'laptop',
    desktop: 'desktop'
} as const;

type ObjValue<T> = T[keyof T];
type TypeView = ObjValue<typeof TypeViewRender>

interface Props extends SwiperProps {
    /** mobile: < 640
     * ipad: < 768
     * laptop: < 1024
     * desktop: >1024
    */
    typeViewRender?: TypeView
}

const DaLatSwiper = (props: Props) => {

    const getSizeDisplayCurrent = () => {
        const currentSizeDisplay = window.innerWidth;
        if (currentSizeDisplay <= 640) {
            return 'mobile';
        }
        if (currentSizeDisplay <= 768) {
            return 'ipad';
        }
        if (currentSizeDisplay <= 1024) {
            return 'laptop';
        }
        if (currentSizeDisplay >= 1024) {
            return 'desktop';
        }
    };

    const isRender = () => {
        if (props.typeViewRender) {
            return props.typeViewRender === getSizeDisplayCurrent();
        } else {
            return true;
        }
    };

    const renderSwiper = () => {

    };

    return (
        <div className='dalat-swiper'>
            <Swiper
                // install Swiper modules
                // modules={[Navigation, Pagination, Scrollbar, A11y]}
                spaceBetween={50}
                slidesPerView={1}
                navigation
                pagination={{ clickable: true }}
                scrollbar={{ draggable: true }}
                onSwiper={(swiper) => console.log(swiper)}
                onSlideChange={() => console.log('slide change')}
                {...props}
            >
                {React.Children.map(props.children, (child) => {
                    return <SwiperSlide>{child}</SwiperSlide>;
                })}

            </Swiper>
        </div>
    );
};

DaLatSwiper.propType = {
    children: PropTypes.node.isRequired
};

export default DaLatSwiper;
