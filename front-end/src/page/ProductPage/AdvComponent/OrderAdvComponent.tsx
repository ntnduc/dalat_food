import DaLatIcon from 'component/DaLatIcon';


const OrderAdvComponent = () => {
    return (
        <div className="item-other-adv group p-5 xl:p-6 3xl:p-7 flex items-center">
            <div className="icon flex shrink-0 items-center justify-center bg-brand-light rounded-full w-[65px] md:w-[70px] xl:w-20 3xl:w-[90px] h-[65px] md:h-[70px] xl:h-20 3xl:h-[90px] shadow-featured">
                <DaLatIcon iconType="share" />
            </div>
        </div>
    );
};

export default OrderAdvComponent;
